-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, active, rank) VALUES ('green', 77, 45);
INSERT INTO layout_items (region, active, rank) VALUES ('strict', 81, 55);
INSERT INTO layout_items (region, active, rank) VALUES ('green', 18, 15);
