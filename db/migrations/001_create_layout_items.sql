-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, rank, weight, level, active) VALUES ('legacy', 32, 96.25, 55, 99);
INSERT INTO layout_items (label, rank, weight, level, active) VALUES ('edge', 74, 97.13, 52, 43);
