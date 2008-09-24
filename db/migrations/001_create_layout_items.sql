-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, rank) VALUES ('standard', 88, 55);
INSERT INTO layout_items (region, level, rank) VALUES ('standard', 87, 56);
INSERT INTO layout_items (region, level, rank) VALUES ('eu-west', 95, 52);
