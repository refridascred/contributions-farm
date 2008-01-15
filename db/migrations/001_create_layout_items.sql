-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, score, ratio) VALUES ('latest', 3.27, 47.31);
INSERT INTO layout_items (region, score, ratio) VALUES ('blue', 56.28, 73.15);
INSERT INTO layout_items (region, score, ratio) VALUES ('latest', 34.84, 29.51);
