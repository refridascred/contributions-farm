-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, owner, ratio, weight) VALUES ('standard', 67, 'edge', 17.82, 17.33);
INSERT INTO layout_items (region, count, owner, ratio, weight) VALUES ('open', 51, 'stable', 29.62, 3.09);
