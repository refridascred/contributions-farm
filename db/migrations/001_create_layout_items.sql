-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, ratio, count, rank, active) VALUES (83, 26.52, 51, 83, 57);
