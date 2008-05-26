-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, count) VALUES ('fallback', 'local', 62);
INSERT INTO layout_items (region, owner, count) VALUES ('eu-west', 'eu-west', 72);
INSERT INTO layout_items (region, owner, count) VALUES ('edge', 'staging', 13);
