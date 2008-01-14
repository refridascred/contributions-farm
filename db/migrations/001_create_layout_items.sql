-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (region, weight, score) VALUES ('legacy', 83.28, 87.97);
INSERT INTO layout_items (region, weight, score) VALUES ('staging', 34.17, 33.73);
