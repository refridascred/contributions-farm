-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight, token, active) VALUES ('green', 7.4, 'standard', 50);
INSERT INTO layout_items (region, weight, token, active) VALUES ('green', 87.24, 'local', 86);
