-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, active, level, rank) VALUES (75.71, 66, 72, 21);
INSERT INTO layout_items (ratio, active, level, rank) VALUES (77.46, 97, 23, 27);
INSERT INTO layout_items (ratio, active, level, rank) VALUES (31.58, 10, 51, 53);
