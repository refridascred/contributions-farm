-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, owner) VALUES (60.21, 27.38, 'standard');
INSERT INTO layout_items (weight, score, owner) VALUES (86.56, 51.34, 'eu-west');
INSERT INTO layout_items (weight, score, owner) VALUES (1.02, 30.81, 'latest');
