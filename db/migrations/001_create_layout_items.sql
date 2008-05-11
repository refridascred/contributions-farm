-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, token) VALUES ('standard', 98, 'legacy');
INSERT INTO layout_items (region, rank, token) VALUES ('primary', 68, 'strict');
INSERT INTO layout_items (region, rank, token) VALUES ('green', 0, 'eu-west');
