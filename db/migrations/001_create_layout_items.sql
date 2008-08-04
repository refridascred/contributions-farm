-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, active, rank) VALUES ('fallback', 6, 38);
INSERT INTO layout_items (region, active, rank) VALUES ('open', 67, 83);
INSERT INTO layout_items (region, active, rank) VALUES ('eu-west', 92, 90);
