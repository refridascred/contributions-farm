-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, region, ratio, rank, count) VALUES ('eu-west', 'staging', 32.28, 44, 3);
INSERT INTO layout_items (owner, region, ratio, rank, count) VALUES ('strict', 'primary', 93.55, 35, 20);
INSERT INTO layout_items (owner, region, ratio, rank, count) VALUES ('blue', 'eu-west', 18.58, 14, 20);
