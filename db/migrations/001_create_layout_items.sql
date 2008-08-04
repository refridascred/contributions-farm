-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (label, region, weight, score, rank) VALUES ('eu-west', 'latest', 21.24, 47.79, 58);
INSERT INTO layout_items (label, region, weight, score, rank) VALUES ('cached', 'primary', 56.67, 32.64, 10);
