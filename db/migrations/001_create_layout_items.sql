-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, region, owner, label) VALUES (55.4, 'strict', 'open', 'open');
INSERT INTO layout_items (weight, region, owner, label) VALUES (58.02, 'green', 'local', 'eu-west');
