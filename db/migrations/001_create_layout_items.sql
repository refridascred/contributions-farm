-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, count, region) VALUES ('stable', 80, 'fallback');
INSERT INTO layout_items (owner, count, region) VALUES ('eu-west', 45, 'local');
INSERT INTO layout_items (owner, count, region) VALUES ('cached', 31, 'primary');
