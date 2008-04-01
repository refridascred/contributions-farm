-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, owner, count, active) VALUES (35.32, 'primary', 43, 11);
INSERT INTO layout_items (ratio, owner, count, active) VALUES (28.66, 'strict', 59, 62);
INSERT INTO layout_items (ratio, owner, count, active) VALUES (20.62, 'latest', 74, 44);
