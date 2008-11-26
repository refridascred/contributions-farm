-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, active, rank, ratio) VALUES ('standard', 92, 2, 41.2);
INSERT INTO layout_items (region, active, rank, ratio) VALUES ('legacy', 12, 24, 68.84);
INSERT INTO layout_items (region, active, rank, ratio) VALUES ('cached', 23, 87, 86.07);
