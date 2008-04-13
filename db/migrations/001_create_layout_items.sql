-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, score, region, rank, count) VALUES ('eu-west', 70.29, 'primary', 58, 38);
INSERT INTO layout_items (token, score, region, rank, count) VALUES ('cached', 58.52, 'latest', 86, 71);
INSERT INTO layout_items (token, score, region, rank, count) VALUES ('legacy', 98.25, 'green', 29, 66);
