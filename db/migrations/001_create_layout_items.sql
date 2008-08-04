-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, count, score, owner) VALUES (11.98, 55, 36.13, 'stable');
INSERT INTO layout_items (ratio, count, score, owner) VALUES (68.39, 39, 58.35, 'staging');
INSERT INTO layout_items (ratio, count, score, owner) VALUES (50.1, 91, 46.93, 'blue');
