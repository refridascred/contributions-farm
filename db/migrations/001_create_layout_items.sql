-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, owner, ratio) VALUES (87, 'legacy', 72.51);
INSERT INTO layout_items (level, owner, ratio) VALUES (58, 'fallback', 95.98);
INSERT INTO layout_items (level, owner, ratio) VALUES (87, 'cached', 47.21);
