-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, owner, region, count, ratio) VALUES ('primary', 'eu-west', 'standard', 33, 68.85);
INSERT INTO layout_items (token, owner, region, count, ratio) VALUES ('green', 'primary', 'legacy', 59, 87.38);
