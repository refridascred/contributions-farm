-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, active) VALUES ('open', 88, 66);
INSERT INTO layout_items (token, rank, active) VALUES ('eu-west', 86, 66);
