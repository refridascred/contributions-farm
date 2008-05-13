-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, owner, ratio, weight) VALUES (75, 'local', 33.88, 73.9);
INSERT INTO layout_items (active, owner, ratio, weight) VALUES (53, 'blue', 88.37, 12.45);
