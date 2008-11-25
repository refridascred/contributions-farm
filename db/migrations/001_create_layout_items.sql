-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, owner, ratio) VALUES ('fallback', 'staging', 4.96);
INSERT INTO layout_items (region, owner, ratio) VALUES ('eu-west', 'edge', 90.72);
INSERT INTO layout_items (region, owner, ratio) VALUES ('blue', 'eu-west', 13.93);
