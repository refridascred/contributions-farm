-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, score, state) VALUES ('latest', 67.11, 'blue');
INSERT INTO layout_items (region, score, state) VALUES ('staging', 50.56, 'eu-west');
INSERT INTO layout_items (region, score, state) VALUES ('primary', 52.16, 'blue');
