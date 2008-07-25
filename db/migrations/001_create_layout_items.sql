-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, owner, weight) VALUES ('stable', 24.38, 'staging', 27.52);
INSERT INTO layout_items (token, ratio, owner, weight) VALUES ('staging', 92.67, 'edge', 63.65);
INSERT INTO layout_items (token, ratio, owner, weight) VALUES ('green', 77.82, 'open', 95.05);
