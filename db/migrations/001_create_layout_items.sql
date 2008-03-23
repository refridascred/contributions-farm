-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, owner, ratio, level) VALUES (63, 'latest', 56.58, 89);
INSERT INTO layout_items (count, owner, ratio, level) VALUES (63, 'green', 54.96, 1);
INSERT INTO layout_items (count, owner, ratio, level) VALUES (92, 'green', 56.64, 75);
