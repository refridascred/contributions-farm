-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, owner, level, count, region) VALUES (51.26, 'strict', 45, 9, 'fallback');
INSERT INTO layout_items (score, owner, level, count, region) VALUES (32.49, 'open', 27, 20, 'green');
