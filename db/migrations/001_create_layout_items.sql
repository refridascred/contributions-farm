-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, level, count, owner) VALUES ('legacy', 84, 5, 'standard');
INSERT INTO layout_items (region, level, count, owner) VALUES ('legacy', 11, 50, 'cached');
