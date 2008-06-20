-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, weight, label, state) VALUES (62.04, 6.62, 'strict', 'edge');
INSERT INTO layout_items (score, weight, label, state) VALUES (45.29, 96.4, 'fallback', 'eu-west');
INSERT INTO layout_items (score, weight, label, state) VALUES (82.43, 63.91, 'strict', 'open');
