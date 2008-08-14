-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, weight, rank, region, score) VALUES (41, 22.94, 52, 'cached', 87.2);
INSERT INTO layout_items (level, weight, rank, region, score) VALUES (9, 53.4, 6, 'eu-west', 7.72);
