-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, label, ratio) VALUES ('latest', 'eu-west', 'green', 73.9);
INSERT INTO layout_items (region, owner, label, ratio) VALUES ('green', 'standard', 'staging', 30.44);
INSERT INTO layout_items (region, owner, label, ratio) VALUES ('primary', 'legacy', 'cached', 43.9);
