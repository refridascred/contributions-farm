-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, count, owner, rank) VALUES ('cached', 6, 'eu-west', 55);
INSERT INTO layout_items (region, count, owner, rank) VALUES ('fallback', 71, 'strict', 50);
