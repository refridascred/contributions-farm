-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, region, rank, count) VALUES ('local', 52.07, 'stable', 22, 10);
INSERT INTO layout_items (owner, ratio, region, rank, count) VALUES ('local', 45.49, 'open', 81, 10);
INSERT INTO layout_items (owner, ratio, region, rank, count) VALUES ('eu-west', 17.54, 'eu-west', 88, 67);
