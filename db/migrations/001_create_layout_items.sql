-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, ratio, weight, score, state) VALUES ('open', 73.81, 18.54, 45.43, 'stable');
INSERT INTO layout_items (owner, ratio, weight, score, state) VALUES ('primary', 4.17, 80.27, 26.99, 'primary');
