-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, state, score, active) VALUES (4, 'legacy', 'primary', 87.92, 42);
INSERT INTO layout_items (count, label, state, score, active) VALUES (17, 'fallback', 'blue', 73.76, 0);
INSERT INTO layout_items (count, label, state, score, active) VALUES (92, 'strict', 'edge', 30.76, 63);
