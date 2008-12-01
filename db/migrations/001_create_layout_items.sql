-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, count, state) VALUES (37.31, 'blue', 18, 'primary');
INSERT INTO layout_items (score, label, count, state) VALUES (38.2, 'blue', 81, 'strict');
INSERT INTO layout_items (score, label, count, state) VALUES (21.16, 'primary', 26, 'edge');
