-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, ratio, owner, active) VALUES (0, 9.81, 'primary', 81);
INSERT INTO layout_items (count, ratio, owner, active) VALUES (57, 94.87, 'legacy', 78);
INSERT INTO layout_items (count, ratio, owner, active) VALUES (85, 40.4, 'blue', 45);
