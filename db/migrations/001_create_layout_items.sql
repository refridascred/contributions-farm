-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, owner, weight) VALUES ('staging', 60, 'fallback', 88.43);
INSERT INTO layout_items (region, count, owner, weight) VALUES ('blue', 94, 'primary', 71.37);
INSERT INTO layout_items (region, count, owner, weight) VALUES ('eu-west', 76, 'local', 92.61);
