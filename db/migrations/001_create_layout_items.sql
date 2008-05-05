-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, label, rank, active) VALUES ('stable', 'open', 20, 19);
INSERT INTO layout_items (region, label, rank, active) VALUES ('strict', 'latest', 76, 99);
INSERT INTO layout_items (region, label, rank, active) VALUES ('primary', 'edge', 11, 15);
