-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, region, label, rank) VALUES ('eu-west', 'blue', 'primary', 8);
INSERT INTO layout_items (token, region, label, rank) VALUES ('stable', 'open', 'local', 66);
