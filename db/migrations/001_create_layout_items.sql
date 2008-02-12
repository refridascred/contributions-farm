-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, score, count, rank) VALUES ('staging', 72.91, 81, 43);
INSERT INTO layout_items (region, score, count, rank) VALUES ('latest', 74.81, 21, 97);
INSERT INTO layout_items (region, score, count, rank) VALUES ('staging', 40.14, 11, 43);
