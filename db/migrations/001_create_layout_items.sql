-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, ratio, weight, owner) VALUES ('open', 69.78, 92.79, 'standard');
INSERT INTO layout_items (region, ratio, weight, owner) VALUES ('edge', 31.61, 82.76, 'open');
INSERT INTO layout_items (region, ratio, weight, owner) VALUES ('eu-west', 97.83, 9.2, 'latest');
