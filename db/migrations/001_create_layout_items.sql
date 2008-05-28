-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, owner, ratio) VALUES (19.86, 'eu-west', 57.38);
INSERT INTO layout_items (weight, owner, ratio) VALUES (72.04, 'green', 8.77);
