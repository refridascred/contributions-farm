-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, weight, region, label, state) VALUES (36.0, 31.09, 'eu-west', 'stable', 'cached');
INSERT INTO layout_items (score, weight, region, label, state) VALUES (54.36, 58.17, 'cached', 'blue', 'local');
