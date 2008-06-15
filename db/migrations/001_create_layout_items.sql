-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, level, active, owner) VALUES (77.17, 87, 10, 'green');
INSERT INTO layout_items (ratio, level, active, owner) VALUES (86.3, 15, 98, 'standard');
