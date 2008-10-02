-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, region, count, token, ratio) VALUES (49, 'local', 25, 'open', 15.68);
INSERT INTO layout_items (active, region, count, token, ratio) VALUES (72, 'edge', 54, 'fallback', 61.36);
INSERT INTO layout_items (active, region, count, token, ratio) VALUES (93, 'edge', 62, 'staging', 49.07);
