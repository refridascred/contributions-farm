-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, weight) VALUES ('cached', 84.82, 97.44);
INSERT INTO layout_items (owner, ratio, weight) VALUES ('primary', 18.04, 37.33);
INSERT INTO layout_items (owner, ratio, weight) VALUES ('fallback', 42.37, 6.63);
