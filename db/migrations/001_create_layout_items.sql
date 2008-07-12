-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, active, owner, region, ratio) VALUES (15, 22, 'blue', 'staging', 54.85);
INSERT INTO layout_items (count, active, owner, region, ratio) VALUES (97, 3, 'local', 'latest', 16.65);
