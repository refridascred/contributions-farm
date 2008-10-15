-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, owner, region, weight) VALUES (59, 'primary', 'open', 75.74);
INSERT INTO layout_items (count, owner, region, weight) VALUES (78, 'local', 'staging', 36.89);
INSERT INTO layout_items (count, owner, region, weight) VALUES (78, 'legacy', 'green', 76.44);
