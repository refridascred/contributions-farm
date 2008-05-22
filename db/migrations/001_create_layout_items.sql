-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, ratio, rank) VALUES (96, 33.45, 92);
INSERT INTO layout_items (active, ratio, rank) VALUES (87, 90.23, 79);
INSERT INTO layout_items (active, ratio, rank) VALUES (38, 96.5, 52);
