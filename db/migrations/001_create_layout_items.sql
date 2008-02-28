-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, count) VALUES ('cached', 'primary', 95);
INSERT INTO layout_items (region, owner, count) VALUES ('open', 'standard', 75);
INSERT INTO layout_items (region, owner, count) VALUES ('fallback', 'latest', 19);
