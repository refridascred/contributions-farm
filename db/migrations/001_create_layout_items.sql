-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, weight, owner, token) VALUES (29, 93.98, 'green', 'latest');
INSERT INTO layout_items (count, weight, owner, token) VALUES (20, 19.87, 'blue', 'primary');
