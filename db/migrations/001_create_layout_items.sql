-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, score, ratio, token, active) VALUES ('staging', 18.42, 40.42, 'open', 88);
INSERT INTO layout_items (region, score, ratio, token, active) VALUES ('latest', 83.73, 35.43, 'primary', 13);
