-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, level, owner, ratio) VALUES (77, 12, 'fallback', 61.73);
INSERT INTO layout_items (count, level, owner, ratio) VALUES (64, 51, 'open', 0.14);
INSERT INTO layout_items (count, level, owner, ratio) VALUES (44, 74, 'staging', 23.19);
