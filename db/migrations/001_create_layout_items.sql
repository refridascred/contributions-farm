-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, owner, weight) VALUES (15.9, 'latest', 'local', 6.45);
INSERT INTO layout_items (ratio, label, owner, weight) VALUES (73.71, 'green', 'eu-west', 7.49);
