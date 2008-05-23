-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, score, count) VALUES ('local', 45.62, 37);
INSERT INTO layout_items (region, score, count) VALUES ('cached', 17.19, 51);
INSERT INTO layout_items (region, score, count) VALUES ('green', 64.05, 32);
