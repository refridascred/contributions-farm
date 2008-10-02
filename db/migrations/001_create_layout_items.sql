-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, weight, owner, level) VALUES ('blue', 42.51, 'green', 17);
INSERT INTO layout_items (region, weight, owner, level) VALUES ('primary', 56.37, 'open', 82);
INSERT INTO layout_items (region, weight, owner, level) VALUES ('standard', 16.1, 'blue', 68);
