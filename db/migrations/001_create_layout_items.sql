-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight, active, label, score) VALUES ('strict', 1.86, 9, 'primary', 37.29);
INSERT INTO layout_items (state, weight, active, label, score) VALUES ('stable', 15.13, 15, 'open', 4.7);
