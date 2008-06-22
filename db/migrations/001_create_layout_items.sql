-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, rank) VALUES ('stable', 'blue', 75);
INSERT INTO layout_items (region, token, rank) VALUES ('latest', 'staging', 34);
INSERT INTO layout_items (region, token, rank) VALUES ('open', 'eu-west', 88);
