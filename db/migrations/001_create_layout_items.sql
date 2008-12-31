-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, level, rank) VALUES ('latest', 95, 5);
INSERT INTO layout_items (token, level, rank) VALUES ('staging', 31, 27);
INSERT INTO layout_items (token, level, rank) VALUES ('open', 83, 30);
