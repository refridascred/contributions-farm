-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, owner, ratio) VALUES ('eu-west', 'open', 'edge', 16.85);
INSERT INTO layout_items (region, token, owner, ratio) VALUES ('strict', 'open', 'primary', 40.4);
