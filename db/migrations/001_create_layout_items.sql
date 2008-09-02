-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, label, active, state) VALUES (46.27, 'green', 94, 'fallback');
INSERT INTO layout_items (weight, label, active, state) VALUES (2.85, 'fallback', 82, 'local');
INSERT INTO layout_items (weight, label, active, state) VALUES (54.49, 'strict', 23, 'edge');
